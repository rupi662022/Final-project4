function ajaxCall2(method, api, data, successCB, errorCB) {
    $.ajax({
        type: method,
        url: api,
        data: data,
        cache: false,
        headers: {
<<<<<<< Updated upstream
            'x-rapidapi-key': '3d6c24db64msh3beae04c060ecdap1a453djsn478b3e38fe7a',   // replace it with your own key
=======
<<<<<<< HEAD
            'x-rapidapi-key': 'd226defdf7msh8fd3746255b50e1p1d499ejsn5e4154c0eefe',   // replace it with your own key
=======
            'x-rapidapi-key': '3d6c24db64msh3beae04c060ecdap1a453djsn478b3e38fe7a',   // replace it with your own key
>>>>>>> 99bdca16236b7e94e40ee57a8062f8495901b1da
>>>>>>> Stashed changes
        },
        contentType: "application/json",
        dataType: "json",
        success: successCB,
        error: errorCB
    });
}