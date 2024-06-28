using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Pvecluster = Pulumi.Pvecluster;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new Pvecluster.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

