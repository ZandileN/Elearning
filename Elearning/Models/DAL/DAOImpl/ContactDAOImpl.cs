using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class ContactDAOImpl : DAO_Contact, IDisposable
    {

        public Contact FindByID(string name)
        {
            Contact con = null;
            using (ElearningEntities e = new ElearningEntities())
            {
                try
                {
                   con = e.Contacts.First(i => i.Email == name);
                }
                catch {

                    return con;
                }
                return con;
            }  
        }

        public List<Contact> FindAll()
        {
            using (ElearningEntities e = new ElearningEntities())
                {
                    List<Contact> c = new List<Contact>();
                    try
                    {
                        IEnumerable<Contact> contact = e.Contacts.OrderBy(i => i.Email);
                        c = contact.ToList();  
                    }
                    catch {

                        c = null;
                    }
                return c;
                }
        }

        public  bool  Persist(Contact entity)
        {
            bool isPersisted = true;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {

                    e.Contacts.Add(entity);
                    e.SaveChanges();
                }
               
            }
            catch (Exception e)
            {
                isPersisted = false;
                Console.WriteLine(e.ToString());
            }

            return isPersisted;
        }

        public bool Merge(Contact entity)
        {
            bool isMerged = true;


            using (ElearningEntities e = new ElearningEntities())
            {
                Contact contact;
                try
                {
                    contact = e.Contacts.First(i => i.ContactID == entity.ContactID);
                    contact.Email = entity.Email;
           
                   e.SaveChanges();
                }
                catch
                {
                    isMerged = false;
                }
            }

            return isMerged;
        }

        public bool Remove(Contact entity)
        {
            bool isMerged = true;


            using (ElearningEntities e = new ElearningEntities())
            {
                Contact contact;
                try
                {
                    contact = e.Contacts.First(i => i.ContactID == entity.ContactID);
                    e.Contacts.Remove(contact);
                    e.SaveChanges();
                }
                catch
                {
                    isMerged = false;
                }

            }

            return isMerged;
        }

        public void Dispose()
        {
            
        }
    }
}