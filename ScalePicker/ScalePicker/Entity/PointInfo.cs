using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ScalePicker.Entity
{
    class PointInfo
    {
        /// <summary>
        /// X座標
        /// </summary>
        public int X;

        /// <summary>
        /// Y座標
        /// </summary>
        public int Y;

        /// <summary>
        /// Twip計算用のシステム解像度
        /// </summary>
        public int TwipRate;

        public PointInfo(int rate)
        {
            this.X = 0;
            this.Y = 0;
            this.TwipRate = rate;
        }

        public PointInfo(int x, int y, int rate)
        {
            this.X = x;
            this.Y = y;
            this.TwipRate = rate;
        }

        public PointInfo(Point p, int rate)
        {
            this.X = p.X;
            this.Y = p.Y;
            this.TwipRate = rate;
        }

        /// <summary>
        /// 座標用文字列に変換(モード指定)
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        public string ToString(Mode mode)
        {
            int x = this.X;
            int y = this.Y;

            if(mode == Mode.Twip)
            {
                x = CalcTwip(this.X);
                y = CalcTwip(this.Y);
            }
            return string.Format("({0, 5},{1, 5})", x, y);
        }

        /// <summary>
        /// 座標をPoint型に変換
        /// </summary>
        /// <returns></returns>
        public Point ToPoint()
        {
            return new Point(this.X, this.Y);
        }

        /// <summary>
        /// 2点間のオフセットを求める
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public PointInfo GetOffset(PointInfo p)
        {
            return new PointInfo(this.X - p.X, this.Y - p.Y, this.TwipRate);
        }

        /// <summary>
        /// 2点間との角度を求める
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetRadian(PointInfo p)
        {
            double calc = Math.Atan2(this.Y - p.Y, this.X - p.X);
            int result = (int)Math.Round(calc * (180 / Math.PI));

            return result;
        }

        /// <summary>
        /// 原点からの距離を求める(モード指定)
        /// </summary>
        /// <returns></returns>
        public int GetLength(Mode mode)
        {
            int result = (int)Math.Round(Math.Pow((double)this.X * (double)this.X + (double)this.Y * (double)this.Y, 0.5), 0);

            if (mode == Mode.Twip)
            {
                result = CalcTwip(result);
            }

            return result;
        }

        /// <summary>
        /// オブジェクトの複製
        /// </summary>
        /// <returns></returns>
        public PointInfo Copy()
        {
            return new PointInfo(this.X, this.Y, this.TwipRate);
        }

        /// <summary>
        /// Twipに換算
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int CalcTwip(int value)
        {
            //Twips = (Pixel / 解像度) * 1440 で計算
            return (value * 1440) / this.TwipRate;
        }

    }

    /// <summary>
    /// 表示モード
    /// </summary>
    public enum Mode
    {
        Pixel,
        Twip,
    }

}
