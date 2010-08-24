using System;
using System.Collections.Generic;
using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using MCloud.Provider.Model;

namespace MCloud.Provider.EC2
{

    public class EucNodeDriver : EC2Driver
    {

        public EucNodeDriver(string key, string secret)
            : base(key, secret)
        {
            Client = AWSClientFactory.CreateAmazonEC2Client(Key, Secret);
        }

        public AmazonEC2 Client
        {
            get;
            private set;
        }

        public override NodeProvider Provider
        {
            get { return NodeProvider.EC2_EU; }
        }

    }

}

