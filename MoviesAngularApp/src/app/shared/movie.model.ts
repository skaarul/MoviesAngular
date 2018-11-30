export class MovieModel {
  MovieId: number;
  MovieName: string;
  ReleaseYear: number;
  Plot: string;
  ProducerId: number;
  ProducerName: string;
  Actors: ActorModel[];
  ActorsArray: number[];
}
export class ActorModel {
  ActorId: number;
  ActorName: string;
  DOB: Date;
  Gender: number;
  Bio: string;
}
export class ProducerModel {
  ProducerId: number;
  ProducerName: string;
  DOB: Date;
  Gender: number;
  Bio: string;
}
export class newpr {
  Id: number;
  UserName: string;
  DOB: Date;
  Gender: boolean;
  Bio: string;
}
