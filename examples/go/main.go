package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		ctx.Export("output", map[string]interface{}{
			"value": myRandomResource.Result,
		})
		return nil
	})
}
