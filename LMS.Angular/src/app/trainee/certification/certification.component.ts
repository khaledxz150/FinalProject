import { Component, OnInit } from '@angular/core';
import html2canvas from 'html2canvas';
import jspdf from 'jspdf';

@Component({
  selector: 'app-certification',
  templateUrl: './certification.component.html',
  styleUrls: ['./certification.component.css']
})
export class CertificationComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  title = 'html-to-pdf-angular-application';
  public print()
  {
  var data:any = document.getElementById('contentToConvert');
  html2canvas(data).then((canvas: { height: number; width: number; toDataURL: (arg0: string) => any; }) => {
  // Few necessary setting options
  var imgWidth = 450;
  var pageHeight = 500;
  var imgHeight = canvas.height * imgWidth / canvas.width;
  var heightLeft = imgHeight;
  
  const contentDataURL = canvas.toDataURL('image/png')
  let pdf = new jspdf('l', 'mm', 'a4'); // A4 size page of PDF
  var position = 0;
  pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)
  pdf.save('new-file.pdf'); // Generated PDF
  });
  }
}
