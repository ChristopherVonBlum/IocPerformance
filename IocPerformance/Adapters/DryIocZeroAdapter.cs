﻿// Ignored. Reason: Not installable in VS 2017 via Nuget
using System;
using DryIocZero;

namespace IocPerformance.Adapters
{
    [Fast]
    public sealed class DryIocZeroAdapter : ContainerAdapterBase
    {
        private Container container;

        public override string PackageName => "DryIocZero";

        public override string Url => "https://bitbucket.org/dadhi/dryioc";

        public override bool SupportsConditional => true;

        public override bool SupportGeneric => false;

        public override bool SupportsMultiple => true;

        public override bool SupportsInterception => false;

        public override bool SupportsPropertyInjection => true;

        public override object Resolve(Type type) => container.Resolve(type, false);

        public override void Dispose() => container?.Dispose();

        public override void Prepare() => PrepareBasic();

        public override void PrepareBasic()
        {
            container = new Container();
        }
    }
}