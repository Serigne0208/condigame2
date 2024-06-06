using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.Fini
{
    class _50_TryCatch
    {
        public void Run(Service s, Connection c)
        {
            Exception e = null;

            try
            {
                s.SetConnection(c);
                s.Execute();
                c.Commit();
            }
            catch (Exception ex)
            {
                c.Rollback();
                e = ex;
            }
            finally
            {
                c.Close();
                if (e != null) throw e;
            }

        }
    }
    public interface Service
    {
        void Execute();
        void SetConnection(Connection c);
    }
    public interface Connection
    {
        void Commit();
        void Rollback();
        void Close();
    }
}

