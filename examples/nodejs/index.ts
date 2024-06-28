import * as pulumi from "@pulumi/pulumi";
import * as pvecluster from "@pulumi/pvecluster";

const myRandomResource = new pvecluster.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
