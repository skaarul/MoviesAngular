import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/shared/movie.service';
import { NgForm } from '@angular/forms';
import { newpr } from 'src/app/shared/movie.model';

@Component({
  selector: 'app-actor-producer',
  templateUrl: './actor-producer.component.html',
  styleUrls: ['./actor-producer.component.css']
})
export class ActorProducerComponent implements OnInit {
  constructor(private service: MovieService) { }
  
  
  ngOnInit() {
    this.resetForm();
  }
  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }
    this.service.formnewdata = {
      Id: null,
      UserName: '',
      DOB: null,
      Gender: true,
      Bio: null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.rectype == "producer") {
      this.service.producer = {
        ProducerName: form.value.UserName,
        Gender: form.value.Gender,
        Bio: form.value.Bio,
        ProducerId: null,
        DOB: null
      }
      this.service.SaveNewProducer().subscribe(res => { this.RefreshList(form) });
    }
    else {
      this.service.actorinfo = {
        ActorName: form.value.UserName,
        Gender: form.value.Gender,
        Bio: form.value.Bio,
        ActorId: null,
        DOB: null
      }
      this.service.SaveNewActor().subscribe(res => { this.RefreshList(form) });
    }
  }
  RefreshList(form: NgForm) {
    this.resetForm(form);
    this.service.refreshactorlist();
    this.service.refreshproducerlist();
  }
}
