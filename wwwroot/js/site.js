$(function () {
    console.log("document ready");
    $(document).on("click", ".edit-product-button", function () {
        console.log("you just clicked button number " + $(this).val());

        //store vehicle id number

        var vehicleID = $(this).val();

        $.ajax({
            type: 'json',
            data: {
                "id": vehicleID
            },



            url: 'vehicle/ShowOneProductJSON',
            success: function (data) {
                console.log(data);

                //fill input fields int he modal

                $("#modal-input-id").val(data.id);
                $("#modal-input-brand").val(data.vehicleBrand);
                $("#modal-input-name").val(data.modelName);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);

            }
        });

    });

    $("#save-button").click(function () {

        // get values from input fields and create a json object to submit to the controller
        var Vehicle = {
            "Id": $("#modal-input-id").val(),
            "VehicleBrand": $("#modal-input-brand").val(),
            "ModelName": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val(),
        }
        console.log("Saved");
        console.log(Vehicle);

        //save updated vehicle record in database using controller

        $.ajax({
            type: 'json',
            data: Vehicle,
            url: '/vehicle/EditProcessReturnPartial',
            success: function (data) {
                console.log(data);
                $("#card-number-" + Vehicle.Id).html(data);
            }
        });

    })

})