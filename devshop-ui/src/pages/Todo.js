import React, {useState, useEffect} from 'react';
import axios from 'axios';
import { StyledFormArea, StyledFormButton } from '../components/Styles.js';

const Todo = () => {
  const [data, setData] = useState({ hits: [] });
  const [query, setQuery] = useState('redux');
  const [url, setUrl] = useState('https://hn.algolia.com/api/v1/search?query=redux');
  const [isLoading, setLoading] = useState(false);
  const [isError, setError] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      setError(false);
      setLoading(true);

      try {
        const result = await axios(url);
        console.log(result);
        setData(result.data);
      } catch (error) {
        setError(true);
      }

      setLoading(false);
    };
    fetchData();
  }, [url]);

  return (
    <StyledFormArea>
      <form
        onSubmit={e => {
          setUrl(`http://hn.algolia.com/api/v1/search?query=${query}`)

          e.preventDefault();
        }}
      >
      <input
        type="text"
        value={query}
        onChange={event => setQuery(event.target.value)}
      />
        <StyledFormButton type="submit">Search</StyledFormButton>
      </form>

      {isError && <div>Somethin went wrong ...</div>}

      {isLoading ? (
        <div>Loading ...</div>
      ) : (<ul>
        {data.hits.map((item, i) => (
          <li key={i}>
            <a href={item.url}>{item.title}</a>
          </li>
        ))}
      </ul>
      )}
    </StyledFormArea>
  );
};

export default Todo;