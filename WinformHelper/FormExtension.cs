using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public static class FormExtension
    {
        
        public static void MdiChildShow<TForm>(this Form form)
            where TForm : Form, new()
        {
            if (!form.IsMdiContainer)
            {
                throw new Exception("Bu form MdiContainer durumunda olmadığından bu işlem yapılamaz.");
            }
            TForm frm = new TForm();
            frm.MdiParent = form;
            frm.Show();
        }     
        public static void MdiBroShow<TForm>(this Form form)
            where TForm : Form, new()
        {
            if (form.MdiParent==null)
            {
                throw new Exception("Bu formun MdiParent ögesi bulunmadığından bu işlem yapılamaz.");
            }
            TForm frm = new TForm();
            frm.MdiParent = form.MdiParent;
            frm.Show();
        }
        public static void MdiBroShow<TForm, T>(this Form form, T entity)
            where TForm : Form where T:class,new()
        {
            if (form.MdiParent == null)
            {
                throw new Exception("Bu formun MdiParent ögesi bulunmadığından bu işlem yapılamaz.");
            }
            TForm frm = (TForm)Activator.CreateInstance(typeof(TForm),entity);
            frm.MdiParent = form.MdiParent;
            frm.Show();

        }

    }
}
