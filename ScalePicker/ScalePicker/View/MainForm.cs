using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScalePicker.View
{
    public partial class MainForm : Form
    {
        Presenter.MainFormPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();

            this._presenter = new Presenter.MainFormPresenter(this);
        }

    }
}
