import { useEffect } from 'react';
import { dispatch } from 'react-redux';
import { RateTable } from "../components/Exchange/RateTable";
import { CurrencyCodePicker } from "../components/Exchange/CurrencyCodePicker";
import { AmountField } from "../components/Exchange/AmountField";


export const Exchange = () => {
  return (
    <div>
      <section>
        <h1 className="ExchangeRate-header">
          Exchange Rates <CurrencyCodePicker />
        </h1>
      </section>
      <section>
        <AmountField />
      </section>
      <section>
        <RateTable />
      </section>
    </div>
  );
}