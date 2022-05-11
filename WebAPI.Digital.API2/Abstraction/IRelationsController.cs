using Microsoft.AspNetCore.Mvc;
using WebAPI.Digital.API2.Domain;

namespace WebAPI.Digital.API2.Abstraction
{
    public interface IRelationController
    {
    
            public IActionResult GetAll();
            public IActionResult GetRelationFromUrlWithTwoAttributesInUrl(string idD, string name);
            public IActionResult GetRelationFromUrlWithTwoParams(string idD, string name);
            public IActionResult AddRelation(Relations relation);
            public IActionResult UpdateRelation(string idDigital, Relations updatedRelation);
            public IActionResult DeleteRelation(string idDigital);

    }
}
