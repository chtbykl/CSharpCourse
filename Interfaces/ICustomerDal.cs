﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }
    }

    class OracleCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }

        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }
}
