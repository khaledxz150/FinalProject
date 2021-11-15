import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CourseService } from 'src/app/Service/course.service';
import { SectionInfoService } from 'src/app/Service/section-info.service';

@Component({
  selector: 'app-section-info',
  templateUrl: './section-info.component.html',
  styleUrls: ['./section-info.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css'
]
})
export class SectionInfoComponent implements OnInit {
  constructor(private activatedRoute: ActivatedRoute,
    public sectionService:SectionInfoService,public courseService:CourseService) {
    const id = this.activatedRoute.snapshot.paramMap.get('id');
    if(id !=null){
    this.sectionService.GetSectionInfoById(parseInt(id));
    }
  }

  ngOnInit(): void {
  }

}
