import axios from 'axios';
import { ICardService } from "@/types/Card";
import { IServiceResponse } from "@/types/ServiceResponse";

/**
 * Card Service
 * Provides UI business logic associated with Customers in our system
 */
export default class CardService {
    API_URL = process.env.VUE_APP_API_URL;

    public async getCards(): Promise<ICardService[]> {
        let result: any = await axios.get(`${this.API_URL}/card/`);
        return result.data;
    };

    public async addCard(newCard: ICardService): Promise<IServiceResponse<ICardService>> {
        let result: any = await axios.post(`${this.API_URL}/card/`, newCard);
        return result.data;
    };

    public async deleteCard(cardId: number): Promise<boolean> {
        let result: any = await axios.delete(`${this.API_URL}/card/${cardId}`);
        return result.data;
    };
}