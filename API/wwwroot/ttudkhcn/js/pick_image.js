//CCCD
var cccdsa = document.getElementById("CCCDsa");
var previewCCCDsa = document.getElementById("previewCCCDsa");
var btnAddCCCDsa = document.getElementById("btnAddCCCDsa");
var chonHinhCCCDsaKhac = document.getElementById("chonHinhCCCDsaKhac");
if (cccdsa != null) {
    cccdsa.onchange = evt => {
        const [file] = cccdsa.files
        if (file) {
            previewCCCDsa.src = URL.createObjectURL(file);
            previewCCCDsa.classList.remove("hidden");
            chonHinhCCCDsaKhac.classList.remove("hidden");
            btnAddCCCDsa.classList.add("hidden");
        }
    }
}

var cccdtr = document.getElementById("CCCDtr");
var previewCCCDtr = document.getElementById("previewCCCDtr");
var btnAddCCCDtr = document.getElementById("btnAddCCCDtr");
var chonHinhCCCDKhactr = document.getElementById("chonHinhCCCDtrKhac");
if (cccdtr != null) {
    cccdtr.onchange = evt => {
        const [file] = cccdtr.files
        if (file) {
            previewCCCDtr.src = URL.createObjectURL(file);
            previewCCCDtr.classList.remove("hidden");
            chonHinhCCCDtrKhac.classList.remove("hidden");
            btnAddCCCDtr.classList.add("hidden");
        }
    }
}

//QSDD tr
var qsddtr = document.getElementById("QSDDtr");
var previewQSDDtr = document.getElementById("previewQSDDtr");
var btnAddQSDDtr = document.getElementById("btnAddQSDDtr");
var chonHinhQSDDtrKhac = document.getElementById("chonHinhQSDDtrKhac");
if (qsddtr != null) {
    qsddtr.onchange = evt => {
        const [file] = qsddtr.files
        if (file) {
            previewQSDDtr.src = URL.createObjectURL(file);
            previewQSDDtr.classList.remove("hidden");
            chonHinhQSDDtrKhac.classList.remove("hidden");
            btnAddQSDDtr.classList.add("hidden");
        }
    }
}

//QSDD sa
var qsddsa = document.getElementById("QSDDsa");
var previewQSDDsa = document.getElementById("previewQSDDsa");
var btnAddQSDDsa = document.getElementById("btnAddQSDDsa");
var chonHinhQSDDsaKhac = document.getElementById("chonHinhQSDDsaKhac");
if (qsddsa != null) {
    qsddsa.onchange = evt => {
        const [file] = qsddsa.files
        if (file) {
            previewQSDDsa.src = URL.createObjectURL(file);
            previewQSDDsa.classList.remove("hidden");
            chonHinhQSDDsaKhac.classList.remove("hidden");
            btnAddQSDDsa.classList.add("hidden");
        }
    }
}