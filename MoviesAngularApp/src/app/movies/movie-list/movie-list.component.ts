import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/shared/movie.service';
import { MovieModel } from 'src/app/shared/movie.model';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  constructor(private service: MovieService) { }

  ngOnInit() {
    this.service.refreshmovielist();
  }
  AddMovie() {
    this.service.IsMovieEdit = false;
    this.service.hidemovieslist();
  }
  EditMovie(mov: MovieModel) {
    this.service.IsMovieEdit = true;
    this.service.formData = mov;
    this.service.hidemovieslist();
  }
}
