function addCompareForm() {
    alert("add new ");
}

function removeCompareForm() {
    alert("remove");
}

function calculate() {
    var alimentationPerWeek = document.getElementById("yacht1alimemtationPerWeekInput");
    var fuelFeePerWeek = document.getElementById("yacht1fuelFeePerWeekInput");
    var captainSalaryPerWeek = document.getElementById("yacht1captainSalaryWeekInput");
    document.getElementById("yacht1sumPerWeekInput").value = parseInt(alimentationPerWeek.value, 10) + parseInt(fuelFeePerWeek.value, 10) + parseInt(captainSalaryPerWeek.value, 10);
    console.log("przeliczone");

}

function lockAlimentationPerWeek() {

    var alimentationPerWeek = document.getElementById("yacht1alimemtationPerWeekInput");
    var alimemtationPerDay = document.getElementById("yacht1alimemtationPerDayInput");
    var alimentationPerPerson = document.getElementById("yacht1alimemtationPerPersonInput");

    if (alimentationPerWeek.value.length != 0) {
        console.log("wlacz");
        alimemtationPerDay.readOnly = true;
        alimentationPerPerson.readOnly = true;
    }
    else {
        console.log("wylacz");
        document.getElementById("yacht1alimemtationPerDayInput").readOnly = false;
        document.getElementById("yacht1alimemtationPerPersonInput").readOnly = false;
    }

    calculate();
}

function lockAlimentationPerDay() {

    var alimentationPerWeek = document.getElementById("yacht1alimemtationPerWeekInput");
    var alimemtationPerDay = document.getElementById("yacht1alimemtationPerDayInput");
    var alimentationPerPerson = document.getElementById("yacht1alimemtationPerPersonInput");

    if (alimemtationPerDay.value.length != 0) {
        console.log("wlacz");
        alimentationPerWeek.readOnly = true;
        alimentationPerPerson.readOnly = true;
    }
    else {
        console.log("wylacz");
        alimentationPerWeek.readOnly = false;
        alimentationPerPerson.readOnly = false;
    }
}

function lockAlimentationPerPerson() {

    var alimentationPerWeek = document.getElementById("yacht1alimemtationPerWeekInput");
    var alimemtationPerDay = document.getElementById("yacht1alimemtationPerDayInput");
    var alimentationPerPerson = document.getElementById("yacht1alimemtationPerPersonInput");

    if (alimentationPerPerson.value.length != 0) {
        console.log("wlacz");
        alimemtationPerDay.readOnly = true;
        alimentationPerWeek.readOnly = true;
    }
    else {
        console.log("wylacz");
        alimemtationPerDay.readOnly = false;
        alimentationPerWeek.readOnly = false;
    }
}

    //var fuel = document.getElementById("yacht1fuelFeePerWeekInput");

    //if (fuel.value.length != 0) {
    //    console.log("wlacz");
    //    document.getElementById("yacht1fuelFeePerDayInput").readOnly = true;
    //    document.getElementById("yacht1fuelFeePerPersonInput").readOnly = true;
    //}
    //else {
    //    console.log("wylacz");
    //    document.getElementById("yacht1fuelFeePerDayInput").readOnly = false;
    //    document.getElementById("yacht1fuelFeePerPersonInput").readOnly = false;
    //}

    

