export interface ICardService {
    CardId: number;
    createdOn: Date;
    updatedOn?: Date;
    Title: string;
    ShortUrl: string;
    Description: string;
    CardImage: ImageBitmap;
}