using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic.Models
{
    public class MvcBasicInitializer:DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member>
            {
                new Member
                {
                    Name = "山田",
                    Email = "rio@wings.msn.to",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "ピアノが好きです"
                },

                new Member
                {
                    Name = "浜田",
                    Email = "hamada@wings.msn.to",
                    Birth = DateTime.Parse("1990-06-25"),
                    Married = false,
                    Memo = "サッカーが好きです"
                }
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}