﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data;
        public LargeDataCollection(List<object> initialData)
        {
            data = new List<object>(initialData);
        }

        public void Add(object item)
        {
            data.Add(item);
        }

        public bool Remove(object item)
        {
            return data.Remove(item);
        }

        public object GetElement(int index)
        {
            if (index >= 0 && index < data.Count)
                return data[index];

            return null;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (data != null)
                {
                    data.Clear();
                    data = null;
                }
            }
        }
    }


}
