using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScalePicker.View
{
    public partial class FieldForm : Form
    {
        Presenter.FieldFormPresenter _presenter;

        public FieldForm()
        {
            InitializeComponent();

            this._presenter = new Presenter.FieldFormPresenter(this);
        }
    }
}
