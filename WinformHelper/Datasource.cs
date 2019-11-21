using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformHelper
{
    public static class Datasource
    {
        public static void Yukle<T>(this ListControl control,DbContext db,string displayMember, string valueMember)
            where T : class
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = db.Set<T>().ToList();

        }

        public static void Yukle<T>(this ListControl control, IEnumerable<T> data,string displayMember, string valueMember)
            where T : class
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = data.ToList();

        }
        public static void Yukle<T>(this ListControl control, DbContext db, string displayMember, string valueMember, Expression<Func<T, bool>> filter)
            where T : class
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = db.Set<T>().Where(filter).ToList();

        }
        public static void Yukle<T>(this ListControl control, DbContext db, string displayMember, string valueMember, Expression<Func<T, bool>> filter, Expression<Func<T, bool>> filter2)
            where T : class 
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = db.Set<T>().Where(filter).Where(filter2).ToList();

        }
        public static void LoadEnum<TEnum>(this ListControl control)
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new Exception("Bu metot sadece enum tipi için kullanılabilir.");
            }

            var enums = ((TEnum[])Enum.GetValues(typeof(TEnum))) // bu satırdaki kod enum üzerindeki tüm değerleri dizi olarak verir.
                .Select(e => new { Value = Convert.ToInt32(e), Name = e.ToString() }) //burada ilgili dizi elemanlarını listeleme öğelerinde görünmesi için value ve text(display) formatına çekiyoruz.
                .ToList();

            control.DataSource = enums;
            control.DisplayMember = "Name";
            control.ValueMember = "Value";
        }
        public static void SaveChangesControll(this DbContext db, EventHandler e = null)
        {
            try
            {
                int ess = db.SaveChanges();
                if (ess > 0)
                {
                    if (e != null && e.Method != null)
                    {
                        e(null, EventArgs.Empty);
                    }
                    MessageBox.Show("Islem basarilidir.");
                }
                else
                {
                    MessageBox.Show("Islem gerektiren bir durum bulunamadi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata nedeniyle işlem yapılamadi.");
            }
        }
    }
}
