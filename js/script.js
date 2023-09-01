function printInvoke(value) {
    if (value.Data == "FiveByFive") {
        var opt = {
            filename: 'bingocard.pdf',
            jsPDF: { orientation: 'portrait' },
            html2canvas: { scale: 1.5, logging: true }
        };
        html2pdf(document.body, opt);
    } else {
        var opt = {
            filename: 'bingocard.pdf',
            jsPDF: { orientation: 'landscape' },
            html2canvas: { scale: 1.5, logging: true }
        };
        html2pdf(document.body, opt);
    }
    
}

function Test() {
    let capturingElement = getTokenizedElement("capture-element-token");
    let capturingElementClone = capturingElement.cloneNode();
    cloneStyle(capturingElement.childNodes, capturingElementClone);
    let printWindow = window.open("", "_blank", 'toolbar=0,location=0,menubar=0');
    printWindow.document.write('<html><head><title></title>');
    printWindow.document.write('</head><body style="background-color:#111;">');
    printWindow.document.write(capturingElementClone.outerHTML);
    printWindow.document.write('</body></html>');
    printWindow.document.close();
    printWindow.focus();
    printWindow.print();
}

function getTokenizedElement(token) {
    return document.querySelector(`[data-blazor-token="${token}"]`)
}

function cloneStyle(sourceChildren, target) {
    for (let i = 0; i < sourceChildren.length; i++) {
        let childClone = sourceChildren[i].cloneNode();

        if (sourceChildren[i].childNodes.length == 0) {
            childClone.innerText = sourceChildren[i].innerText;
        }

        if (sourceChildren[i] instanceof Element) {
            let styles = window.getComputedStyle(sourceChildren[i]);
            Array.from(styles).forEach(key => childClone.style.setProperty(key, styles.getPropertyValue(key), 'important'));
        }

        target.appendChild(childClone);
        cloneStyle(sourceChildren[i].childNodes, childClone);
    }
}