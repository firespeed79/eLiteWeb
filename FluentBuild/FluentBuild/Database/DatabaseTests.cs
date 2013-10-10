﻿using NUnit.Framework;

namespace FluentBuild.Database
{
    ///<summary />
    public class DatabaseTests
    {
        ///<summary />
        public void ShouldCreateProperObject()
        {
            Assert.That(Database.MsSqlDatabase, Is.TypeOf(typeof(MsSqlConnection)));
        }
    }
}