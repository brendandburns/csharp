using System;
using System.Collections.Generic;
using k8s.Models;

namespace KubectlDotNet
{
    public class TypeMapper
    {
        public class GroupVersionKind
        {
            public string Group { get; set; }
            public string Version { get; set; }

            public string Kind { get; set; }

            public string Plural { get; set; }

            public GroupVersionKind(string group, string version, string kind, string plural)
            {
                this.Group = group;
                this.Version = version;
                this.Kind = kind;
                this.Plural = plural;
            }
        }

        private Dictionary<Type, GroupVersionKind> typeMap;
        private static TypeMapper staticMap;

        private TypeMapper()
        {
            typeMap = new Dictionary<Type, GroupVersionKind>();
        }

        static TypeMapper()
        {
            var map = TypeMapper.Instance();
            map.typeMap[typeof(V1Pod)] = new GroupVersionKind("", "v1", "pod", "pods");
            map.typeMap[typeof(V1PodList)] = new GroupVersionKind("", "v1", "pod", "pods");
            map.typeMap[typeof(V1Node)] = new GroupVersionKind("", "v1", "node", "nodes");
            map.typeMap[typeof(V1NodeList)] = new GroupVersionKind("", "v1", "node", "nodes");
            // TODO: Dynamic type loading here.
        }

        public GroupVersionKind GetGroupVersionKind(Type t)
        {
            return typeMap[t];
        }

        public static TypeMapper Instance()
        {
            if (staticMap == null)
            {
                staticMap = new TypeMapper();
            }

            return staticMap;
        }
    }
}
