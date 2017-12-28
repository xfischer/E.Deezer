﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E.Deezer.Api
{
    internal interface IDeserializable<T>
    {
        T Client { get; }

        void Deserialize(T aClient);
    }

    internal static class DeserializeableExtensions
    {
        // Extension to aid deserialization of lists :)
        public static void Deserialize<T>(this IEnumerable<T> aItems, IDeezerClient aClient) where T : IDeserializable<IDeezerClient>
        {
            foreach (T item in aItems)
            {
                item.Deserialize(aClient);
            }
        }
    }
}
