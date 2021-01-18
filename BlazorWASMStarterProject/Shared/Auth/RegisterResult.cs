using System.Collections.Generic;

namespace BlazorWASMStarterProject.Shared.Auth
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
