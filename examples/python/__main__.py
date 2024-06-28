import pulumi
import pulumi_pvecluster as pvecluster

my_random_resource = pvecluster.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
