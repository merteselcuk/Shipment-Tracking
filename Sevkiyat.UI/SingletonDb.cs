using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevkiyat.UI
{
    public class SingletonDb
    {
        private static SevkiyatDBEntities _context;
        public static SevkiyatDBEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new SevkiyatDBEntities();
                }
                return _context;
            }
        }
    }
}
