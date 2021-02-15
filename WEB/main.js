{ // Kurulum
console.log("Kuş Dili Çeviricisi! Kurulum yapılıyor...");
var cevrilen = document.getElementById("Cevrilen");
var ceviri = document.getElementById("Ceviri");
var cevirMod = document.getElementById("CevirMod");
var cevirHarf = document.getElementById("CevirHarf");
var cvrButon = document.getElementById("Cevir");
var kopyala = document.getElementById("Kopyala");
}

cvrButon.addEventListener("click", function(){
    var sesliHarfler = ["a","e","ı","i","u","ü","o","ö"];
    ceviri.value = "";
    if(cevirMod.value == "Turkce"){
        // Türkçe'den Kuş Dili'ne
        for(i = 0; i < cevrilen.value.length; i++){
            if(sesliHarfler.includes(cevrilen.value.charAt(i).toLowerCase())){
                if(sesliHarfler.includes(cevrilen.value.charAt(i))){
                    // Eğer küçük harfse
                ceviri.value += cevrilen.value.charAt(i) + cevirHarf.value + cevrilen.value.charAt(i);
                } else {
                    ceviri.value += cevrilen.value.charAt(i) + cevirHarf.value.toUpperCase() + cevrilen.value.charAt(i);
                }
            } else {
                ceviri.value += cevrilen.value.charAt(i);
            }
        }
    } else {
        // Kuş Dili'nden Türkçe'ye
        for(i = 0; i < cevrilen.value.length; i++){
            ceviri.value += cevrilen.value.charAt(i);
            if(sesliHarfler.includes(cevrilen.value.charAt(i).toLowerCase())){
                i+= cevirHarf.value.length + 1;
            }
        }
    }
    kopyala.disabled = (ceviri.value == "")
});

kopyala.addEventListener("click", function(){
    ceviri.select(); ceviri.setSelectionRange(0, 99999);
    document.execCommand("copy");
});