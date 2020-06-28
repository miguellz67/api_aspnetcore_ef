import { Event } from './Event';
import { SocialNetWork } from './SocialNetWork';

export interface Speaker {
    id: number;
    name: string;
    about: string;
    imgURL: string;
    phone: string;
    email: string;
    // Relation EF
    socialNetWork: SocialNetWork[];
    eventSpeaker: Event[];
}
