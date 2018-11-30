import { Component, OnInit } from '@angular/core';
import { MovieModel } from 'src/app/shared/movie.model';
import { NgForm } from '@angular/forms';
import { MovieService } from 'src/app/shared/movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  constructor(private service:MovieService) { }

  ngOnInit() {
    this.service.refreshactorlist();
    this.service.refreshproducerlist();
    console.log(this.service.formData);
    if (this.service.IsMovieEdit == false) {
      this.resetForm();
    }
  }
  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }
    this.service.formData = {
      MovieId: null,
      MovieName:'',
      ReleaseYear: null,
      Plot: '',
      ProducerId:null,
      ProducerName: '',
      Actors: null,
      ActorsArray:null
    }
  }
  onSubmit(form: NgForm) {
    console.log(form.value);
    if (form.value.MovieId == null) {
      this.insertRecord(form);
    }
    else {
      this.UpdateRecord(form);
    }
  }
  insertRecord(form: NgForm) {
    this.service.SaveMovie(form.value).subscribe(res => { this.formsubmitactions(form) });
  }
  UpdateRecord(form: NgForm) {
    this.service.Updatemovie(form.value).subscribe(res => { this.formsubmitactions(form) });
  }
  formsubmitactions(form: NgForm) {
    this.resetForm(form)
    this.service.showmovieslist();
  }
  GotoMovies() {
    this.service.IsMovieEdit = false;
    this.service.showmovieslist();
  }
}
