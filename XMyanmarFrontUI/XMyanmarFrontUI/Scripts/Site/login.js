var LoginViewController = function () {

    this.Initialize = function () {
        $('#SignIn').click(function () {
        // Clear localstorage and delete all cookie
        localStorage.clear();
        //CommonUtil.DeleteAllCookie();
       
        $.ajax({
            type: 'POST',
            url: appRootDir + '/Login/Submit',
            dataType: "json",
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(param),
        }).done(function (data) {
            
        }).fail(function (jqXHR, textStatus, errorThrown) {          
        });
        });

        
}