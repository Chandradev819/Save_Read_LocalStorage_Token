using Blazor.IndexedDB;
using Microsoft.JSInterop;
using System;

namespace LocalStorageDemo.Model
{
    public class TokenDB : IndexedDb
    {
        public TokenDB(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<TokenInfo> tblTokens { get; set; }
    }
}
