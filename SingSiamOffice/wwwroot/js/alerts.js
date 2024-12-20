﻿function confirmSaveData() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะบันทึกข้อมูล ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'บันทึก',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */a
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}

function confirm() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'บันทึกสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}

function alert_error() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'บันทึกไม่สำเร็จ กรุณาตรวจสอบ',
        showConfirmButton: true,
        timer: 2500
    })
}
function alert_error_pay_notenough() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'ยอดเงินชำระไม่พอ กรุณาตรวจสอบ',
        showConfirmButton: true,
        timer: 2500
    })
}
function alert_customer_blacklist(data) {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'บันทึกไม่สำเร็จ เนื่องจากลูกค้า ติดBlacklist สาขา:'+data,
        showConfirmButton: true,
        timer: 2500
    })
}
function goblack() {
    window.goBack = function () {
        history.back();
    }
}
function alert_login_fail() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'Username หรือ Password ไม่ถูกต้อง!',
        showConfirmButton: true,
        timer: 2500
    })
}
function alert(data) {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: data,
        showConfirmButton: false,
        timer: 5000
    })
}
function confirmdelete() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะลบข้อมูล ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'ลบข้อมูล',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}

function deletesuccess() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'ลบข้อมูลสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}
function printDiv(divId) {
    // Get the content of the div
    const divContent = document.getElementById(divId).innerHTML;

    // Get all styles applied to the current document
    const styles = Array.from(document.styleSheets)
        .map(styleSheet => {
            try {
                return Array.from(styleSheet.cssRules)
                    .map(rule => rule.cssText)
                    .join('\n');
            } catch (e) {
                return ''; // Skip inaccessible stylesheets
            }
        })
        .join('\n');

    // Open a new window
    const printWindow = window.open('', '', 'height=600,width=800');

    // Write the content and styles into the new window
    printWindow.document.write(`
                <html>
                <head>
                    <title>Print Div</title>
                    <style>${styles}</style>
                </head>
                <body>${divContent}</body>
                </html>
            `);

    // Close the document to finish writing
    printWindow.document.close();

    // Focus and trigger the print dialog
    printWindow.focus();
    printWindow.print();
    printWindow.close();
}
function delete_error() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'ลบข้อมูลไม่สำเร็จ กรุณาตรวจสอบ',
        showConfirmButton: true,
        timer: 2500
    })
}

function clear() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'ล้างข้อมูลค้นหาสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}


function search() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'ค้นหาสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}

function idcard_notfound() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'ไม่พบบัตรประชาชน กรุณาดำเนินการใหม่อีกครั้ง',
        showConfirmButton: false,
        timer: 1500
    })
}

function deleteSlip() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะยกเลิกใบเสร็จ ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'ยกเลิกใบเสร็จ',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}

function deleteContract() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะยกเลิกสัญญา ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'ยกเลิกสัญญา',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}

function deleteContractSuccess() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'ยกเลิกสัญญาสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}


function confirmSaveData() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะบันทึกข้อมูล ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'บันทึก',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}
function alert_bk() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'พบรายชื่อใน Black List',
        showConfirmButton: false,
        timer: 1500
    })
}
function confirm() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'บันทึกสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}

function alert_error() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'บันทึกไม่สำเร็จ กรุณาตรวจสอบ',
        showConfirmButton: true,
        timer: 2500
    })
}




function confirmPayment() {
    return new Promise(reslove => {
        Swal.fire({
            title: 'คุณต้องการที่จะยืนยันชำระรายการ ใช่หรือไม่',
            showDenyButton: true,
            showCancelButton: false,
            confirmButtonText: 'ยืนยัน',
            denyButtonText: `ยกเลิก`,
        }).then((result) => {

            /* Read more about isConfirmed, isDenied below */
            reslove(result.isConfirmed)
            //if (result.isConfirmed) {
            //    reslove(result.isConfirmed)
            //    Swal.fire('บันทีกสำเร็จ!', '', 'success')
            //} else if (result.isDenied) {
            //    Swal.fire('บันทีกไม่สำเร็จ กรุณาบันทึกอีกครั้ง', '', 'info')
            //}
        })
    });

}

function paymentsuccess() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'ชำระรายการสำเร็จ',
        showConfirmButton: false,
        timer: 1500
    })
}

function paymenterror() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'ชำระไม่รายการสำเร็จ กรุณาตรวจสอบ',
        showConfirmButton: true,
        timer: 2500
    })
}
function paymenterror_amount() {
    Swal.fire({
        position: 'center',
        icon: 'error',
        title: 'กรุณาใส่จำนวนเงินที่ต้องชำระ',
        showConfirmButton: true,
        timer: 2500
    })
}