using System.Collections.Generic;

namespace BlazorWASMStarterProject.Shared.Auth
{
    public class ResetPasswordResult
    {
        public bool Successful { get; set; }
        public List<string> Errors { get; set; }
    }
}