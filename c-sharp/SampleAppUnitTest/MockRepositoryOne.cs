using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp;

namespace SampleAppUnitTest
{
    class MockRepositoryOne : IRepository
    {
        public int GetBaseValue()
        {
            return 1; 
        }
    }
}
