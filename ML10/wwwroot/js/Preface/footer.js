function Footer(stringData) {
	document.write("<p class=\"version\">" + stringData + " -  Versiуn " + issueNumber + "</p>");
	document.write("<p>" + copyrightString + "</p>");
}

function FrontFooter(dateString) {
	document.write("<p align=\"left\" class=\"TD\"><strong>" + copyrightString + "&nbsp;-&nbsp;" + issueDate + "<br>Versiуn " + issueNumber + "</strong></td>");
}
