using System;
using System.Collections.Generic;
using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using MCloud.Provider.Model;

namespace MCloud.Provider.EC2
{

    public class Ec2EuNodeDriver : EC2Driver
    {

        public Ec2EuNodeDriver(string key, string secret)
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

