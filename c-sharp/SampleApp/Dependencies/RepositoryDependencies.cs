using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Dependencies.vNextDependencyBuilder;


namespace SampleApp.Dependencies.ServiceRepository
{
    public class RepositoryDependencies
    {
        public static readonly DependencyBuilder<long> restClientBuilder = DependencyBuilder<long>.builderForValue(new long());

        public static void resetAll()
        {
            restClientBuilder.make();
        }
    }
}
