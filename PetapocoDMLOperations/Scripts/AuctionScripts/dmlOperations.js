

function Create(url) {

	//debugger;
	
	$.ajax({
		url: url,
		type: "get"
	}).done(function (response) {
		$("#contentArea").html(response);

	});
	

}