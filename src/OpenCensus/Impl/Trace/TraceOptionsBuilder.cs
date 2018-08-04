﻿// <copyright file="TraceOptionsBuilder.cs" company="OpenCensus Authors">
// Copyright 2018, OpenCensus Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of theLicense at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace OpenCensus.Trace
{
    public class TraceOptionsBuilder
    {
        private byte options;

        internal TraceOptionsBuilder()
            : this(TraceOptions.DEFAULT_OPTIONS)
        {
        }

        internal TraceOptionsBuilder(byte options)
        {
            this.options = options;
        }

        public TraceOptionsBuilder SetIsSampled(bool isSampled)
        {
            if (isSampled)
            {
                this.options = (byte)(this.options | TraceOptions.IS_SAMPLED);
            }
            else
            {
                this.options = (byte)(this.options & ~TraceOptions.IS_SAMPLED);
            }

            return this;
        }

        public TraceOptions Build()
        {
            return new TraceOptions(this.options);
        }
    }
}
