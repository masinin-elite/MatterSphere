﻿using FWBS.OMS.OMSEXPORT;
using FWBS.OMS.OMSEXPORT.ResetFlagCommands;
using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSExportE3E.Tests.ResetFlagCommands
{
    [TestFixture]
    public class ResetNeedExportFlagForContactCommandTest : ResetNeedExportFlag
    {
        private const long ContactId = 1;       

        [SetUp]
        public void Startup()
        {            
            Provider = MockRepository.GenerateMock<IDatabaseProvider>();
            Command = new ResetNeedExportFlagForContactCommand(ContactId, Provider);
        }


        [Test]
        public void ShouldReleaseIResetNeedExportFlagCommandInterface()
        {
            Assert.IsInstanceOf<IResetNeedExportFlagCommand>(Command);
        }

        [Test]
        public void ShouldInvokeExecuteSqlWithCorrectSqlString()
        {
            Provider
                .Stub(provider => 
                    provider
                        .ExecuteSQL(
                            Arg<string>.Is.NotNull, 
                            Arg<IEnumerable<SqlParameter>>.Is.NotNull))
                        .Return(0);

            Command.Execute();

            Provider
                .AssertWasCalled(provider => 
                    provider
                        .ExecuteSQL(
                            Arg<string>.Is.Equal("UPDATE DBCONTACT SET CONTNEEDEXPORT = 0 WHERE CONTID = @CONTID"), 
                            Arg<IEnumerable<SqlParameter>>.Is.Anything));
        }

        [Test]
        public void ShouldInvokeExecuteSqlWithCorrectParameters()
        {
            Provider
                .Stub(provider => 
                    provider
                        .ExecuteSQL(
                            Arg<string>.Is.NotNull, 
                            Arg<IEnumerable<SqlParameter>>.Is.NotNull))
                        .Return(0);
            
            Command.Execute();

            Provider
                .AssertWasCalled(provider =>
                    provider
                        .ExecuteSQL(
                            Arg<string>.Is.NotNull,
                            Arg<IEnumerable<SqlParameter>>.List.Count(Rhino.Mocks.Constraints.Is.Equal(1))));
        }       
    }
}
