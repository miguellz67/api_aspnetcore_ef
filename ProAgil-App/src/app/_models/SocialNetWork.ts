import { Event } from './Event';
import { Speaker } from './Speaker';

export interface SocialNetWork {
    id: number;
    name: string;
    uRL: string;
    eventId?: number;
    event: Event;
    speakerId?: number;
    speaker: Speaker;
}
