// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcgv = Google.Cloud.GeminiDataAnalytics.V1Beta;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcgv::ContextRetrievalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContextRetrievalServiceClient(this IServiceCollection services, sys::Action<gcgv::ContextRetrievalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::ContextRetrievalServiceClientBuilder builder = new gcgv::ContextRetrievalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::ContextRetrievalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContextRetrievalServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcgv::ContextRetrievalServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcgv::ContextRetrievalServiceClientBuilder builder = new gcgv::ContextRetrievalServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::DataAgentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataAgentServiceClient(this IServiceCollection services, sys::Action<gcgv::DataAgentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::DataAgentServiceClientBuilder builder = new gcgv::DataAgentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::DataAgentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataAgentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcgv::DataAgentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcgv::DataAgentServiceClientBuilder builder = new gcgv::DataAgentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::DataChatServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataChatServiceClient(this IServiceCollection services, sys::Action<gcgv::DataChatServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::DataChatServiceClientBuilder builder = new gcgv::DataChatServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::DataChatServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataChatServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcgv::DataChatServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcgv::DataChatServiceClientBuilder builder = new gcgv::DataChatServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
