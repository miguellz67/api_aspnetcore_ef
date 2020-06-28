import { Lot } from './Lot';
import { SocialNetWork } from './SocialNetWork';
import { Speaker } from './Speaker';

export interface Event {
    id: number;
    location: string;
    date: Date;
    theme: string;
    peoples: number;
    imgURL: string;
    phone: string;
    email: string;

    // Relation EF
    lots: Lot[];
    socialNetWorks: SocialNetWork[];
    eventSpeakers: Speaker;
}
