export interface Lot {
    id: number;
    name: string;
    price: number;
    beginDate: Date;
    endDate: Date;
    amount: number;
    // Relation EF
    eventId: number;
}
