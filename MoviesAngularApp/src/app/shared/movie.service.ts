import { Injectable, NgModuleFactoryLoader } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MovieModel, ActorModel, ProducerModel, newpr } from './movie.model';
import { Console } from '@angular/core/src/console';
import { error } from '@angular/compiler/src/util';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  formData: MovieModel;
  formnewdata: newpr;
  movielist: MovieModel[];
  actorlist: ActorModel[];
  producerlist: ProducerModel[];
  producer: ProducerModel;
  actorinfo: ActorModel;
  showlist: boolean;
  recordtype: string;
  IsMovieEdit: boolean;
  readonly rootUrl = "http://localhost:53075/api";

  constructor(private http: HttpClient) { }
  refreshmovielist() {
    this.http.get(this.rootUrl + '/Movie')
      .toPromise().then(res => this.movielist = res as MovieModel[]);
  }
  refreshactorlist() {
    this.http.get(this.rootUrl + '/actor')
      .toPromise().then(res => this.actorlist = res as ActorModel[]);
  }
  refreshproducerlist() {
    this.http.get(this.rootUrl + '/producer')
      .toPromise().then(res => this.producerlist = res as ProducerModel[] );
  }
  SaveMovie(formData: FormData) {
   return this.http.post(this.rootUrl + '/Movie', formData);
  }
  Updatemovie(formData: FormData) {
    return this.http.put(this.rootUrl + '/Movie', formData);
  }
  showmovieslist() {
    this.IsMovieEdit = false;
    this.showlist = true;
  }
  hidemovieslist() {
    this.showlist = false;
  }
  SaveNewActor() {
    return this.http.post(this.rootUrl + '/Actor', this.actorinfo);
  }
  SaveNewProducer() {
    return this.http.post(this.rootUrl + '/Producer', this.producer);
  }
}
