using System.ComponentModel.DataAnnotations.Schema;

namespace Imagine.Core.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; }
}