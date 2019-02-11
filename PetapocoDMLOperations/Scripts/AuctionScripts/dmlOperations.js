

function Create(url) {


	$.ajax({
		url: url,
		type: "get"
	}).done(function (response) {
		$("#contentArea").html(response);

	});
	

}