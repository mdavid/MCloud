using System;
using System.Collections.Generic;
using MCloud.Provider.Model;

namespace MCloud.Provider.SliceHost
{
    class SliceHostNodeDriver : NodeDriver
    {
        public SliceHostNodeDriver(string key, string secret)
            : base(key, secret)
        {

        }

        public override NodeProvider Provider
        {
            get { return NodeProvider.SliceHost; }
        }

        public override NodeOptions DefaultOptions
        {
            get { throw new NotImplementedException(); }
        }

        public override Node CreateNode(string name, NodeSize size, NodeImage image, NodeLocation location, NodeAuth auth, NodeOptions options)
        {
            throw new NotImplementedException();
        }

        public override void UpdateNode(Node node)
        {
            throw new NotImplementedException();
        }

        public override void DestroyNode(Node node)
        {
            throw new NotImplementedException();
        }

        public override void RebootNode(Node node)
        {
            throw new NotImplementedException();
        }

        public override List<Node> ListNodes()
        {
            throw new NotImplementedException();
        }

        public override List<NodeImage> ListImages()
        {
            throw new NotImplementedException();
        }

        public override List<NodeImage> ListImages(NodeLocation location)
        {
            throw new NotImplementedException();
        }

        public override List<NodeSize> ListSizes()
        {
            throw new NotImplementedException();
        }

        public override List<NodeSize> ListSizes(NodeLocation location)
        {
            throw new NotImplementedException();
        }

        public override List<NodeLocation> ListLocations()
        {
            throw new NotImplementedException();
        }
    }

}