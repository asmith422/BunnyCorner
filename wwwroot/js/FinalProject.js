function bunnyQuiz() {
	var bunnyList =
		[{ size: "big", animals: "yes", schedule: "busy", personality: "shy", pic: "flemishgiant.jpeg", description: "a Flemish Giant Rabbit", screenCol: "#FFEB3B" },
			{ size: "big", animals: "yes", schedule: "busy", personality: "outgoing", pic: "rexrabbit.jpeg", description: "a Rex Rabbit", screenCol: "#00BCD4" },
			{ size: "big", animals: "yes", schedule: "moderate", personality: "shy", pic: "rexrabbit.jpeg", description: "a Rex Rabit", screenCol: "#00BCD4" },
			{ size: "big", animals: "yes", schedule: "moderate", personality: "outgoing", pic: "americanrabbit.jpeg", description: "an American Rabbit", screenCol: "#F44336" },
			{ size: "big", animals: "yes", schedule: "free", personality: "shy", pic: "flemishgiant.jpeg", description: "a Flemish Giant Rabbit", screenCol: "#FFEB3B" },
			{ size: "big", animals: "yes", schedule: "free", personality: "outgoing", pic: "flemishgiant.jpeg", description: "a Flemish Giant Rabbit", screenCol: "#FFEB3B" },
			{ size: "big", animals: "no", schedule: "busy", personality: "shy", pic: "rexrabbit.jpeg", description: "a Rex Rabbit", screenCol: "#00BCD4" },
			{ size: "big", animals: "no", schedule: "busy", personality: "outgoing", pic: "americanrabbit.jpeg", description: "an American Rabbit", screenCol: "#F44336" },
			{ size: "big", animals: "no", schedule: "moderate", personality: "shy", pic: "europeanrabbit.jpeg", description: "an European Rabbit", screenCol: "#FFC107" },
			{ size: "big", animals: "no", schedule: "moderate", personality: "outgoing", pic: "dutchrabbit.png", description: "a Dutch Rabbit", screenCol: "#8BC34A" },
			{ size: "big", animals: "no", schedule: "free", personality: "shy", pic: "europeanrabbit.jpeg", description: "an European Rabbit", screenCol: "#FFC107" },
			{ size: "big", animals: "no", schedule: "free", personality: "outgoing", pic: "/dutchrabbit.png", description: "a Dutch Rabbit", screenCol: "#8BC34A" },
			{ size: "small", animals: "yes", schedule: "busy", personality: "shy", pic: "netherlanddwarf.jpeg", description: "a Netherland Dwarf Rabbit", screenCol: "#E1BEE7" },
			{ size: "small", animals: "yes", schedule: "busy", personality: "outgoing", pic: "/hollandlop.jpeg", description: "a Holland Lop", screenCol: "#448AFF" },
			{ size: "small", animals: "yes", schedule: "moderate", personality: "shy", pic: "lionhead.jpeg", description: "a Lionhead", screenCol: "#F8BBD0" },
			{ size: "small", animals: "yes", schedule: "moderate", personality: "shy", pic: "polishrabbit.jpeg", description: "a Polish Rabbit", screenCol: "#C5CAE9" },
			{ size: "small", animals: "yes", schedule: "free", personality: "outgoing", pic: "hollandlop.jpeg", description: "a Holland Lop", screenCol: "#448AFF" },
			{ size: "small", animals: "yes", schedule: "free", personality: "shy", pic: "/minilop.jpeg", description: "a Mini Lop", screenCol: "#D7CCC8" },
			{ size: "small", animals: "no", schedule: "busy", personality: "outgoing", pic: "netherlanddwarf.jpeg", description: "a Netherland Dwarf Rabbit", screenCol: "#E1BEE7" },
			{ size: "small", animals: "no", schedule: "busy", personality: "shy", pic: "/hollandlop.jpeg", description: "a Holland Lop", screenCol: "#448AFF" },
			{ size: "small", animals: "no", schedule: "moderate", personality: "outgoing", pic: "lionhead.jpeg", description: "a Lionhead", screenCol: "#F8BBD0" },
			{ size: "small", animals: "no", schedule: "moderate", personality: "shy", pic: "polishrabbit.jpeg", description: "a Polish Rabbit", screenCol: "#C5CAE9" },
			{ size: "small", animals: "no", schedule: "free", personality: "shy", pic: "netherlanddwarf.jpeg", description: "a Netherland Dwarf Rabbit", screenCol: "#E1BEE7" },
			{ size: "small", animals: "no", schedule: "free", personality: "outgoing", pic: "minilop.jpeg", description: "a Mini Lop", screenCol: "#D7CCC8" }];

	var sizeSel, animalsSel, personalitySel, bunnyPic = "", bunnyDesc = "", screenColor = "white", text;
	var t = document.getElementById('bunny');
	var f = document.getElementById('fname');
	var l = document.getElementById('lname');
	var s = document.getElementById('schedule');
	var d = document.getElementsByName('size');
	var v = document.getElementsByName('animals');
	var p = document.getElementsByName('personality');
	document.getElementById("resultStatement").style.display = "inline-block";
	document.body.style.backgroundColor = "#d1d1e0";

	for (i = 0; i < d.length; i++) {
		if (d[i].checked) {
			sizeSel = d[i].value;
			break;
		}
	}

	for (i = 0; i < v.length; i++) {
		if (v[i].checked) {
			animalsSel = v[i].value;
			break;
		}
	}

	for (i = 0; i < p.length; i++) {
		if (p[i].checked) {
			personalitySel = p[i].value;
			break;
		}
	}



	for (i = 0; i <bunnyList.length; i++) {
		if ((bunnyList[i].animals == animalsSel) && (bunnyList[i].schedule == s.value) && (bunnyList[i].size == sizeSel) && (bunnyList[i].personality == personalitySel)) {
			bunnyDesc = bunnyList[i].description;
			bunnyPic = bunnyList[i].pic;
			screenColor = bunnyList[i].screenCol;
			break;
		}

	}

	if (bunnyPic == "") {
		document.getElementById("resultStatement").innerHTML = "You did not make a selection, so we suggest the Holland Lop.";
		bunnyPic = "hollandlop.jpeg";
	}
	else {
		text = "Hi " + f.value + " " + l.value + "!  The best bunny for you would be " + bunnyDesc + ".";
		document.getElementById("resultStatement").innerHTML = text;
	}

	document.body.style.backgroundColor = screenColor;
}



function refreshMe() {
	var f = document.getElementById('fname');
	var l = document.getElementById('lname');
	var s = document.getElementById('schedule');
	var d = document.getElementsByName('size');
	var v = document.getElementsByName('animals');
	var p = document.getElementsByName('personality');

	for (i = 0; i < d.length; i++) {
		if (d[i].checked) {
			d[i].checked = false;
			break;
		}
	}
	for (i = 0; i < v.length; i++) {
		if (v[i].checked) {
			v[i].checked = false;
			break;
		}
	}
	for (i = 0; i < p.length; i++) {
		if (p[i].checked) {
			p[i].checked = false;
			break;
		}
	}
	document.body.style.backgroundColor = "#d1d1e0";
	document.getElementById("resultStatement").innerHTML = "";
	f.value = "";
	l.value = "";
	document.getElementById("resultStatement").style.display = "none";
	s[1].selected = true;
}

