using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SampleApp;

namespace SampleAppUnitTest
{
    class MockRepositoryBadConnection : IRepository
    {
        public int GetBaseValue()
        {
           throw new Exception("Cannot connect to SQL server.");
        }
    }
}
