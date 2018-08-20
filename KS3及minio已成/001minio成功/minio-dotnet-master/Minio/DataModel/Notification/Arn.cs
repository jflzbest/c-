/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2017 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Minio.DataModel
{
    // Arn holds ARN information that will be sent to the web service,
    // ARN desciption can be found in http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html
    public class Arn
    {
       private string Partition { get; }
       private string Service { get; }
       private string Region { get; }
       private string AccountID { get; }
       private string Resource { get; }

        [XmlText]
        private string arnString;

        public Arn()
        {  
        }

        // Pass valid Arn string on aws to constructor
        public Arn(string arnString)
        {
            string[] parts = arnString.Split(':');
            if (parts.Length == 6)
            {
                this.Partition = parts[1];
                this.Service = parts[2];
                this.Region = parts[3];
                this.AccountID = parts[4];
                this.Resource = parts[5];
                this.arnString = arnString;
            }
            
        }
        // constructs new ARN based on the given partition, service, region, account id and resource
        public Arn(string partition, string service, string region, string accountId, string resource)
        {
            this.Partition = partition;
            this.Service = service;
            this.Region = region;
            this.AccountID = accountId;
            this.Resource = resource;
            this.arnString = "arn:" + this.Partition + ":" + this.Service + ":" + this.Region + ":" + this.AccountID + ":" + this.Resource;
        }
        public override string ToString()
        {
            return  arnString;
        }
    }
}