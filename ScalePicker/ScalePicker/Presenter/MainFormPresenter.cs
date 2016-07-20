using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace ScalePicker.Presenter
{
    class MainFormPresenter
    {
        View.MainForm _form;
        View.FieldForm _field;

        Entity.PointInfo _current;
        Entity.PointInfo _base;
        Entity.PointInfo _dragbase;
        Entity.Mode _mode = Entity.Mode.Pixel;

        int _twip;

        bool _dragon = false;
        bool _shifton = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="form"></param>
        public MainFormPresenter(View.MainForm form)
        {
            this._form = form;

            this._twip = GetTwipRate();
            this._base = new Entity.PointInfo(this._twip);
            this._form.DisplayBasePoint.Text = this._base.ToString(this._mode);

            this._field = new View.FieldForm();
            this._field.Show();
            this._field.AddOwnedForm(this._form);

            this._form.TopMost = true;

            SetEvent();
        }

        /// <summary>
        /// イベント
        /// </summary>
        private void SetEvent()
        {
            this._field.MouseDoubleClick += GetBasePoint;
            this._field.MouseDown += StartDrag;
            this._field.MouseUp += EndDrag;
            this._field.MouseMove += GetCurrent;

            this._form.LostFocus += LostApplicationFocus;

            this._form.KeyDown += ShiftDown;
            this._form.KeyUp += ShiftUp;
            this._field.KeyDown += ShiftDown;
            this._field.KeyUp += ShiftUp;

            this._form.ChangeModeButton.Click += ChangeMode;
        }

        /// <summary>
        /// アプリケーションフォーカスが失われた際にTopMostを解除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LostApplicationFocus(object sender, EventArgs e)
        {
            if (!this._field.Focused && !this._form.Focused)
            {
                this._form.TopMost = false;
            }
        }

        /// <summary>
        /// Twip計算用システム解像度取得
        /// </summary>
        /// <returns></returns>
        private int GetTwipRate()
        {
            Graphics g = this._form.CreateGraphics();
            return (int)g.DpiX;
        }

        /// <summary>
        /// 表示モード変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeMode(object sender, EventArgs e)
        {
            this._mode = this._mode == Entity.Mode.Pixel ? Entity.Mode.Twip : Entity.Mode.Pixel;
            this._form.ChangeModeButton.Text = this._mode.ToString();
        }

        /// <summary>
        /// シフトキー開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                this._shifton = true;
                GetCurrent(sender, null);
            }
        }

        /// <summary>
        /// シフトキー解除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShiftUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.ShiftKey)
            {
                this._shifton = false;
                GetCurrent(sender, null);
            }
        }

        /// <summary>
        /// ドラッグ開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartDrag(object sender, MouseEventArgs e)
        {
            this._dragon = true;

            this._dragbase = new Entity.PointInfo(e.Location, this._twip);
            this._form.DragBasePoint.Text = this._dragbase.ToString(this._mode);
        }

        /// <summary>
        /// ドラッグ終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndDrag(object sender, MouseEventArgs e)
        {
            Graphics g = this._field.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            
            this._dragon = false;
            this._form.DragBasePoint.Text = string.Empty;
            this._form.DragOffset.Text = string.Empty;
            this._form.DragLength.Text = string.Empty;
            this._form.DragRadian.Text = string.Empty;
        }

        /// <summary>
        /// 基準点設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetBasePoint(object sender, MouseEventArgs e)
        {
            this._base = new Entity.PointInfo(e.Location, this._twip);
            this._form.DisplayBasePoint.Text = this._base.ToString(this._mode);
        }

        /// <summary>
        /// 移動時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCurrent(object sender, EventArgs e)
        {
            GetCurrentPoint(Cursor.Position);

            if (!this._dragon)
                return;

            AdjustShiftMode(Cursor.Position);
        }


        /// <summary>
        /// 現座標の取得
        /// </summary>
        /// <param name="location"></param>
        private void GetCurrentPoint(Point location)
        {
            if (this._current == null)
            {
                this._current = new Entity.PointInfo(location, this._twip);
            }
            else
            {
                this._current.X = location.X;
                this._current.Y = location.Y;
            }

            this._form.CurrentPoint.Text = this._current.ToString(this._mode);
            this._form.DisplayOffset.Text = this._current.GetOffset(this._base).ToString(this._mode);
            this._form.DisplayLength.Text = this._current.GetOffset(this._base).GetLength(this._mode).ToString();

        }

        /// <summary>
        /// シフトモード調整
        /// </summary>
        /// <param name="location"></param>
        private void AdjustShiftMode(Point location)
        {
            Entity.PointInfo lineend = this._current.Copy();
            if (this._shifton)
            {
                if ((45 < this._current.GetRadian(this._dragbase) && this._current.GetRadian(this._dragbase) < 135)
                    || (-135 < this._current.GetRadian(this._dragbase) && this._current.GetRadian(this._dragbase) < -45))
                {
                    lineend.X = this._dragbase.X;
                }
                else
                {
                    lineend.Y = this._dragbase.Y;
                }
            }
            else
            {
                lineend.X = location.X;
                lineend.Y = location.Y;
            }

            Graphics g = this._field.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            Pen pen = new Pen(Color.Red, 3);
            g.DrawLine(pen, this._dragbase.ToPoint(), lineend.ToPoint());
            pen.Dispose();
            g.Dispose();

            this._form.DragOffset.Text = this._current.GetOffset(this._dragbase).ToString(this._mode);
            this._form.DragLength.Text = this._current.GetOffset(this._dragbase).GetLength(this._mode).ToString();
            this._form.DragRadian.Text = this._current.GetRadian(this._dragbase).ToString();
        }

    }
}
